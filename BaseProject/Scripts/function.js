///
/// 汎用AJAX接続クラス
const FuncAjaxUDS = function (url, data, sucsess) {
    $.LoadingOverlay('show')
    $.ajax({
        url: url,
        method: 'post',
        data: data,
        cache: false,
        timeout: 10000,
    }).done(sucsess).
        fail(function (jqXHR) {
            FuncOpenErrorModal(jqXHR)
        }).always(function () {
            $.LoadingOverlay('hide')
        });
}
///
/// 汎用AJAX接続クラス
const FuncAjaxUDSA = function (url, data, sucsess, always) {
    $.LoadingOverlay('show')
    $.ajax({
        url: url,
        method: 'post',
        data: data,
        cache: false,
        timeout: 10000,
    }).done(sucsess).
        fail(function (jqXHR) {
            FuncOpenErrorModal(jqXHR)
        }).always(always);
}
///
/// 汎用AJAX接続クラス
const FuncAjaxUDSAF = function (url, data, sucsess, always, fail) {
    $.LoadingOverlay('show')
    $.ajax({
        url: url,
        method: 'post',
        data: data,
        cache: false,
        timeout: 10000,
    }).done(sucsess).
        fail(fail).always(always);
}