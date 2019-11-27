const VideoScreen = {
    Video: null,
    PositionStart: null,
    PositionEnd: null,
    Init: function ()
    {
        VideoScreen.SetOnUpdate();
    },  


    Start: function () {              
        VideoScreen.Video.playbackRate = 1.0;
        VideoScreen.Video.currentTime = VideoScreen.PositionStart;
        VideoScreen.Video.play();
    },  

    SetOnUpdate: function () {
        $(VideoScreen.Video).on('timeupdate', function () {
            if (video.currentTime >= VideoScreen.PositionEnd) {
                video.currentTime = VideoScreen.PositionStart;
            }
        });
    },
};

$(document).ready(function () {

    var video = document.getElementById('video');
    var startbtn = document.getElementById('startbtn');
    $(startbtn).on('click', function () {
        VideoScreen.PositionStart = $("#posstart").data("rank")
        VideoScreen.PositionEnd = $("#posend").data("rank")
        VideoScreen.Start();
    });
    
    VideoScreen.Video = video;
    VideoScreen.Init();
   
});

