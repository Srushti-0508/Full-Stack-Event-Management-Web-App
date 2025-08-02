// Write your JavaScript code.
$('.thumbnail').on('click', function () {
    var src = $(this).attr('src');
    $('#enlargedImage').attr('src', src);
});