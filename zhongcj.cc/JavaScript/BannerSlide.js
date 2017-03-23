$(function () {
    var SlideLength = $('.slides li').size() - 1;
    var NowCurrent = 0;
    var Prev = 0;
    var TT = 0;
    var Speed = 5000;


    $('.slides li').eq(0).siblings('li').css({ 'display': 'none' });


    var UlStrat = '<ul id="TabBtns">',
		UlContent = '',
		UlStop = '</ul>';
    AddBtns();
    var TabBtns = $('#TabBtns li');
    var TabBtnsWidth = $('#TabBtns').width();
    $('#TabBtns').css('left', (470 - TabBtnsWidth))

    TabBtns.eq(0).addClass('current')
    //添加圆点按钮
    function AddBtns() {
        for (var i = 0; i <= SlideLength; i++) {
            UlContent += '<li>' + '<a>' + (i + 1) + '</a>' + '</li>';
        }

        $('.slides').after(UlStrat + UlContent + UlStop);
    }

    TabBtns.on('click', DOTCHANGE)

    function DOTCHANGE() {

        var changenow = $(this).index();

        $('.slides li').eq(NowCurrent).css('z-index', '900');
        $('.slides li').eq(changenow).css({ 'z-index': '800' }).show();
        TabBtns.eq(changenow).addClass('current').siblings('li').removeClass('current');
        $('.slides li').eq(NowCurrent).fadeOut(400, function () { $('.slides li').eq(changenow).fadeIn(500); });
        NowCurrent = changenow;
    }

    TabBtns.mouseenter(function () {
        Prev = 1;
    })

    TabBtns.mouseleave(function () {
        Prev = 0;
    })

    function TabBanner() {
        //下一个选中
        var NextCurrent = NowCurrent + 1;

        if (Prev == 1) {
        } else {
            if (NowCurrent < SlideLength) {
                $('.slides li').eq(NowCurrent).css('z-index', '900');
                $('.slides li').eq(NextCurrent).css({ 'z-index': '800' }).show();
                TabBtns.eq(NextCurrent).addClass('current').siblings('li').removeClass('current');
                $('.slides li').eq(NowCurrent).fadeOut(400, function () { $('.slides li').eq(NextCurrent).fadeIn(500); });
                NowCurrent += 1;

            } else {
                NextCurrent = 0;
                $('.slides li').eq(NowCurrent).css('z-index', '900');
                $('.slides li').eq(NextCurrent).stop(true, true).css({ 'z-index': '800' }).show();
                $('.slides li').eq(NowCurrent).fadeOut(400, function () { $('.slides li').eq(0).fadeIn(500); });
                TabBtns.eq(NextCurrent).addClass('current').siblings('li').removeClass('current');

                NowCurrent = 0;

            }
        }
        setTimeout(TabBanner, Speed);
    }

    setTimeout(TabBanner, Speed);

})