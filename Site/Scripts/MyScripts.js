$(".submit-link").click(function() {
    $(this).closest("form").submit();
});
$("[data-focus = true]").focus();