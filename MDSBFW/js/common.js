﻿/** 
* panel关闭时回收内存，主要用于layout使用iframe嵌入网页时的内存泄漏问题
*/
$.fn.panel.defaults.onBeforeDestroy = function () {

    var frame = $('iframe', this);
    try {
        // alert('销毁，清理内存');
        if (frame.length > 0) {
            for (var i = 0; i < frame.length; i++) {
                frame[i].contentWindow.document.write('');
                frame[i].contentWindow.close();
            }
            frame.remove();
            if ($.browser.msie) {
                CollectGarbage();
            }
        }
    } catch (e) {
    }
};

/** 
* 在iframe中调用，在父窗口中出提示框(herf方式不用调父窗口)
*/
$.extend({ show_warning: function (strTitle, strMsg) {
    $.messager.show({
        title: strTitle,
        msg: strMsg,
        showType: 'slide',
        style: {
            right: '',
            top: document.body.scrollTop + document.documentElement.scrollTop,
            bottom: ''
        }
    });
}
});

$.extend({ show_alert: function (strTitle, strMsg) {
    $.messager.alert(strTitle, strMsg);
}
});


/**
* @author 孙宇
* 
* @requires jQuery,EasyUI
* 
* 防止panel/window/dialog组件超出浏览器边界
* @param left
* @param top
*/

var easyuiPanelOnMove = function (left, top) {
    var l = left;
    var t = top;
    if (l < 1) {
        l = 1;
    }
    if (t < 1) {
        t = 1;
    }
    var width = parseInt($(this).parent().css('width')) + 14;
    var height = parseInt($(this).parent().css('height')) + 14;
    var right = l + width;
    var buttom = t + height;
    var browserWidth = $(window).width();
    var browserHeight = $(window).height();
    if (right > browserWidth) {
        l = browserWidth - width;
    }
    if (buttom > browserHeight) {
        t = browserHeight - height;
    }
    $(this).parent().css({/* 修正面板位置 */
        left: l,
        top: t
    });
};
$.fn.dialog.defaults.onMove = easyuiPanelOnMove;
$.fn.window.defaults.onMove = easyuiPanelOnMove;
$.fn.panel.defaults.onMove = easyuiPanelOnMove;


/**
* @author 夏悸
* 
* @requires jQuery,EasyUI
* 
* 扩展tree，使其支持平滑数据格式
*/
$.fn.tree.defaults.loadFilter = function (data, parent) {
    var opt = $(this).data().tree.options;
    var idFiled, textFiled, parentField;
    //alert(opt.parentField);
    if (opt.parentField) {
        idFiled = opt.idFiled || 'id';
        textFiled = opt.textFiled || 'text';
        parentField = opt.parentField;
        var i, l, treeData = [], tmpMap = [];
        for (i = 0, l = data.length; i < l; i++) {
            tmpMap[data[i][idFiled]] = data[i];
        }
        for (i = 0, l = data.length; i < l; i++) {
            if (tmpMap[data[i][parentField]] && data[i][idFiled] != data[i][parentField]) {
                if (!tmpMap[data[i][parentField]]['children'])
                    tmpMap[data[i][parentField]]['children'] = [];
                data[i]['text'] = data[i][textFiled];
                tmpMap[data[i][parentField]]['children'].push(data[i]);
            } else {
                data[i]['text'] = data[i][textFiled];
                treeData.push(data[i]);
            }
        }
        return treeData;
    }
    return data;
};

/**
* @author 孙宇
* 
* @requires jQuery,EasyUI
* 
* 扩展combotree，使其支持平滑数据格式
*/
$.fn.combotree.defaults.loadFilter = $.fn.tree.defaults.loadFilter;

/**
* @author 孙宇
* 
* @requires jQuery,EasyUI
* 
* 通用错误提示
* 
* 用于datagrid/treegrid/tree/combogrid/combobox/form加载数据出错时的操作/combotree
*/
var easyuiErrorFunction = function (XMLHttpRequest) {
    $.messager.progress('close');
    // $.messager.alert('错误', XMLHttpRequest.responseText);
    if (XMLHttpRequest.responseText == "nosession") {    //未登录
        $.relogin();
    }
    else {
        window.parent.window.$.messager.alert('错误', XMLHttpRequest.responseText);
    }
};
$.fn.datagrid.defaults.onLoadError = easyuiErrorFunction;
$.fn.treegrid.defaults.onLoadError = easyuiErrorFunction;
$.fn.tree.defaults.onLoadError = easyuiErrorFunction;
$.fn.combogrid.defaults.onLoadError = easyuiErrorFunction;
$.fn.combobox.defaults.onLoadError = easyuiErrorFunction;
$.fn.form.defaults.onLoadError = easyuiErrorFunction;
$.fn.combotree.defaults.onLoadError = easyuiErrorFunction;

/**
* @author 孙宇
* 
* @requires jQuery,EasyUI
* 
* 扩展validatebox，添加验证两次密码功能
*/
$.extend($.fn.validatebox.defaults.rules, {
    eqPwd: {
        validator: function (value, param) {
            return value == $(param[0]).val();
        },
        message: '密码不一致！'
    }
});

/*
*@zf
*用户未登录 或session超时 弹出登录框重新登录
*/
$.extend({ relogin: function () {

    $("<div/>").attr("id", "dialog_relogin").dialog({
        title: " 未登录或登录超时，请重新登录",
        href: "/htm_ui/ui_relogin.htm",
        width: 300,
        height: 200,
        closable: false,
        iconCls: "icon-lock",
        modal: true,
        buttons: [
        {
            text: "登录",
            iconCls: "icon-key",
            handler: function () {
                var para = {};
                para.uname = $("#relogin_account").val();
                para.pwd = $("#relogin_pwd").val();
                para.action = "login";
                para.timespan = new Date().getTime();
                $.ajax({
                    url: "/ashx_ui/login.ashx",
                    type: "POST",
                    data: para,
                    dataType: "text",
                    success: function (result) {
                        if (result == "ok") {
                            $.show_warning("提示", "登录成功");
                            $("#dialog_relogin").dialog('destroy');
                        }
                        else {
                            $.show_alert("错误", result);
                        }
                    }
                });
            }

        },
        { text: "退出系统",
            iconCls: "icon-cancel",
            handler: function () {
                window.location.href = "/login.htm";
            }
        }
        ]
    })
}
});

/*
*zf
*获取session
*/
function getSession(deal) {
    //alert(12);
    $.ajax({
        url: "/ashx_ui/getsession.ashx",
        type: "POST",
        success: function (r) { deal(r) }
    })
}
/*
*     zf
*     处理ajax返回值通用处理方法 
*     
*/
function dealAjaxResult(result, okFun) {
    if (result == "nosession") {
        $.relogin();
    }
    else if (result == "ok") {
        okFun(result);
    }
    else {
        $.show_alert("错误", result);
    }
}


/**
* @author 孙宇
* 
* @requires jQuery
* 
* 改变jQuery的AJAX默认属性和方法
*/
$.ajaxSetup({
    //  type: 'POST',
    error: function (XMLHttpRequest, textStatus, errorThrown) {
        $.messager.progress('close');
        $.messager.alert('错误', XMLHttpRequest.responseText);
    }
});
var loadMsg = "加载中，请稍等...";
var defaultPageSize = 10;
var defaultPageList = [10, 20, 30, 40, 50];
//把json字符串转换为时间格式
function ChangeDateFormat(cellval) {
    try {
        var date = new Date(parseInt(cellval.replace("/Date(", "").replace(")/", ""), 10));
        var month = date.getMonth() + 1 < 10 ? "0" + (date.getMonth() + 1) : date.getMonth() + 1;
        var currentDate = date.getDate() < 10 ? "0" + date.getDate() : date.getDate();
        return date.getFullYear() + "-" + month + "-" + currentDate;
    } catch (e) {
        return "";
    }
}
//把json字符串转换为长时间格式
function ChangeLongDateFormat(cellval) {
    try {
        var date = new Date(parseInt(cellval.replace("/Date(", "").replace(")/", ""), 10));
        var month = date.getMonth() + 1 < 10 ? "0" + (date.getMonth() + 1) : date.getMonth() + 1;
        var currentDate = date.getDate() < 10 ? "0" + date.getDate() : date.getDate();
        var Hours = date.getHours();
        var Minute = date.getMinutes() < 10 ? "0" + date.getMinutes() : date.getMinutes();
        var Second = date.getSeconds() < 10 ? "0" + date.getSeconds() : date.getSeconds();
        return date.getFullYear() + "-" + month + "-" + currentDate + " " + Hours + ":" + Minute + ":" + Second;
    } catch (e) {
        return "";
    }
}



