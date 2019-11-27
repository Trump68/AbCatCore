// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//var video = document.getElementById('video');
//var intervalRewind;
//$(video).on('play', function () {
//    video.playbackRate = 1.0;
//    clearInterval(intervalRewind);
//});
//$(video).on('pause', function () {
//    video.playbackRate = 1.0;
//    clearInterval(intervalRewind);
//});
//$("#speed").click(function () { // button function for 3x fast speed forward
//    video.playbackRate = 3.0;
//});
//$("#negative").click(function () { // button function for rewind
//    intervalRewind = setInterval(function () {
//        video.playbackRate = 1.0;
//        if (video.currentTime == 0) {
//            clearInterval(intervalRewind);
//            video.pause();
//        }
//        else {
//            video.currentTime += -.1;
//        }
//    }, 30);
//});