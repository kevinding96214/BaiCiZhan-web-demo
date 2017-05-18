//滚动条滚动事件
window.onscroll = function () {
    var navbar = document.getElementsByClassName('navbar-fixed-top');
    var t = document.documentElement.scrollTop || document.body.scrollTop;
    var top_div = document.getElementById("top_div");
    if (t > 50) {
        navbar[0].style.background = "#2EA3FD";
    }
    else {
        navbar[0].style.background = null;
    }
}
//图片轮播
var i = 0;
setInterval(function () {
    var pics = [
        "/Image/down1.jpg",
        "/Image/down2.jpg",
        "/Image/down3.jpg"
    ];
    if (i < 3) {
        bgpic.src = pics[i];
        bgpic.alt = "图片" + (i + 1);
        i++
    }
    else { i = 0; }
}, 5000);

//客户端下载点击事件
var down = document.getElementById('down');
var qr = document.getElementById('downBox');
down.onclick = function () {
    qr.style.display = 'inline-block';
}
down.onblur = function () {
    qr.style.display = 'none';
}

//登录框拖动
var box = document.getElementById('wrap');
var login = document.getElementById('login');
var x = 0;
var y = 0;
window.onload = function () {
    login.onmousedown = function (ev) {
        var oevent = ev || event;
        var distanceX = oevent.clientX - login.offsetLeft;
        var distanceY = oevent.clientY - login.offsetTop;
        login.onmousemove = function (ev) {
            var oevent = ev || event;
            login.style.left = oevent.clientX - distanceX + 'px';
            login.style.top = oevent.clientY - distanceY + 'px';
        }
        login.onmouseup = function () {
            login.onmousemove = null;
            login.onmouseup = null;
        }
    }
    return false;
}

//求职列表切换
var qz = document.getElementsByClassName('qz');
var sx = document.getElementsByClassName('sx');
qz[0].onclick = function () {
    tab1.style.display = null;
    tab2.style.display = "none";
    return false;
}
sx[0].onclick = function () {
    tab1.style.display = "none";
    tab2.style.display = null;
    return false;
}
qz[1].onclick = function () {
    tab1.style.display = null;
    tab2.style.display = "none";
    return false;
}
sx[1].onclick = function () {
    tab1.style.display = "none";
    tab2.style.display = null;
    return false;
}