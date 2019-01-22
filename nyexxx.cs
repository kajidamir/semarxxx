@charset "utf-8";html,body{border:0;margin:0;padding:0}body{
	font: 16px Arial, sans-serif;
	color: #fff;
	overflow: hidden;
	background-color: #0B3251
}.main{height:auto;width:1024px;right:50%;margin-right:-512px;position:absolute;z-index:1000;margin-top:37px}.header{height:auto;text-align:center;font-size:30px;font-style:italic;font-weight:bold;margin-top:auto;margin-right:auto;margin-bottom:20px;margin-left:auto}.logo{height:auto;text-align:center;margin-top:auto;margin-right:auto;margin-bottom:20px;margin-left:auto;font-size:30px;color:#78CD00;font-weight:bold}.title{height:auto;font-size:30px;font-weight:bold;text-align:center;margin:auto}.type{
	height: auto;
	text-align: center;
	margin-top: 30px;
	margin-right: auto;
	margin-bottom: auto;
	margin-left: auto;
	font-size: 20px
}.timer{
	height: 50px;
	text-align: center;
	margin-top: 30px;
	margin-right: auto;
	margin-bottom: 50px;
	margin-left: auto
}#timer1{display:inline;font-weight:bold;font-size:36px}#questions{
	margin: auto;
}#question1,#question2,#question3,#question4{font-family:inherit;text-align:center;font-size:18px}#question2,#question3,#question4{display:none}.buttom2{text-align:center;margin-top:20px;margin-right:10px;margin-bottom:10px;margin-left:10px}.buttom3{text-align:center;margin-top:20px;margin-right:10px;margin-bottom:10px;margin-left:10px}.css_btn_yes{display:inline-block;margin-right:10px;padding:16px 70px;font-size:16px;color:#fff;cursor:pointer;border:1px solid #ccc;background-color:#3F7EE7;text-decoration:none;transition:0.4s}.css_btn_yes:hover{background-color:transparent;color:#fff;transition:0.5s}.css_btn_no{display:inline-block;padding:16px 60px;font-size:16px;color:#fff;cursor:pointer;border:1px solid #ccc;background-color:#3F7EE7;text-decoration:none;transition:0.4s}.css_btn_no:hover{background-color:transparent;color:#fff;transition:0.5s}.css_btn_ok{display:inline-block;margin-right:10px;padding:16px 70px;font-size:16px;color:#fff;cursor:pointer;border:1px solid #ccc;background-color:#3F7EE7;text-decoration:none;transition:0.4s}.css_btn_ok:hover{background-color:transparent;color:#fff;transition:0.5s}.line{color:#FF9900;text-decoration:underline;font-style:normal}h1{font-weight:bold;font-size:36px}.thank{font-weight:bold;font-size:22px}
li {list-style-type:none;}
.cb-slideshow li span {
	width: 100%;
	height: 100%;
	position: absolute;
	top: 0px;
	left: 0px;
	background-size: cover;
	background-position: 50% 50%;
	background-repeat: none;
	opacity: 0;
	-webkit-backface-visibility: hidden;
	-webkit-animation: imageAnimation 30s linear infinite 0s;
	-moz-animation: imageAnimation 30s linear infinite 0s;
	-o-animation: imageAnimation 30s linear infinite 0s;
	-ms-animation: imageAnimation 30s linear infinite 0s;
	animation: imageAnimation 30s linear infinite 0s;
	z-index: -100;
}

.cb-slideshow li:nth-child(1) span {
	background-image: url(https://thumbs.gfycat.com/LeftTornBoaconstrictor-max-1mb.gif)
}
.cb-slideshow li:nth-child(2) span {
	background-image: url(https://thumbs.gfycat.com/LeftTornBoaconstrictor-max-1mb.gif);
	-webkit-animation-delay: 10s;
	-moz-animation-delay: 10s;
	-o-animation-delay: 10s;
	-ms-animation-delay: 10s;
	animation-delay: 10s;
}
.cb-slideshow li:nth-child(3) span {
	background-image: url(https://thumbs.gfycat.com/LeftTornBoaconstrictor-max-1mb.gif
);
	-webkit-animation-delay: 20s;
	-moz-animation-delay: 20s;
	-o-animation-delay: 20s;
	-ms-animation-delay: 20s;
	animation-delay: 20s;
}
@-webkit-keyframes imageAnimation { 
	0% {
	    opacity: 0;
	    -webkit-animation-timing-function: ease-in;
	}
	10% {
	    opacity: 1;
	    -webkit-transform: scale(1.1);
	    -webkit-animation-timing-function: ease-out;
	}
	20% {
	    opacity: 1;
	    -webkit-transform: scale(1.2);
	}
	30% {
		opacity: 0;
	}
	100% {
	    opacity: 0;
	}
}
@-moz-keyframes imageAnimation { 
	0% {
	    opacity: 0;
	    -moz-animation-timing-function: ease-in;
	}
	10% {
	    opacity: 1;
	    -moz-transform: scale(1.1);
	    -moz-animation-timing-function: ease-out;
	}
	20% {
	    opacity: 1;
	    -moz-transform: scale(1.2);
	}
	30% {
		opacity: 0;
	}
	100% {
	    opacity: 0;
	}
}
@-o-keyframes imageAnimation { 
	0% {
	    opacity: 0;
	    -o-animation-timing-function: ease-in;
	}
	10% {
	    opacity: 1;
	    -o-transform: scale(1.1);
	    -o-animation-timing-function: ease-out;
	}
	20% {
	    opacity: 1;
	    -o-transform: scale(1.2);
	}
	30% {
		opacity: 0;
	}
	100% {
	    opacity: 0;
	}
}
@-ms-keyframes imageAnimation { 
	0% {
	    opacity: 0;
	    -ms-animation-timing-function: ease-in;
	}
	10% {
	    opacity: 1;
	    -ms-transform: scale(1.1);
	    -ms-animation-timing-function: ease-out;
	}
	20% {
	    opacity: 1;
	    -ms-transform: scale(1.2);
	}
	30% {
		opacity: 0;
	}
	100% {
	    opacity: 0;
	}
}
@keyframes imageAnimation { 
	0% {
	    opacity: 0;
	    animation-timing-function: ease-in;
	}
	10% {
	    opacity: 1;
	    transform: scale(1.1);
	    animation-timing-function: ease-out;
	}
	20% {
	    opacity: 1;
	    transform: scale(1.2);
	}
	30% {
		opacity: 0;
	}
	100% {
	    opacity: 0;
	}
}