/* ���� js */

$(function () {

    //����ͷ�񳤿��
    var jlFaceImg = $(".jl-face>img");
    $(".jl-face").css("backgroundImage", "url(" + jlFaceImg.attr("src") + ")");
    jlFaceImg.remove();
});