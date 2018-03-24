/* 简历 js */

$(function () {

    //设置头像长宽比
    var jlFaceImg = $(".jl-face>img");
    $(".jl-face").css("backgroundImage", "url(" + jlFaceImg.attr("src") + ")");
    jlFaceImg.remove();
});