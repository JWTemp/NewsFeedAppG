$(function () {
    addMoreNewsBehaviour();
});

function addMoreNewsBehaviour() {
    $(document).delegate("#moreLink", "click", function () {
        $.get($(this).attr("href"), function (response) {
            $('div.stream_news').append($("div.stream_news", response).html());
            $('#moreLink').replaceWith($("#moreLink", response));
        });
        return false;
    });
}