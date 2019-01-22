function display1(){var clp=document.getElementById("question1");clp.style.display="none"}
function display2(){var clp=document.getElementById("question2");clp.style.display="none"}
function display3(){var clp=document.getElementById("question3");clp.style.display="none"}
function hidden1(){document.getElementById('question2').style.display="";setTimeout("disappeare1()",300);}
function disappeare1(){document.getElementById('question2').style.display="block";}
function hidden2(){document.getElementById('question3').style.display="";setTimeout("disappeare2()",300);}
function disappeare2(){document.getElementById('question3').style.display="block";}
function hidden3(){document.getElementById('question4').style.display="";setTimeout("disappeare3()",300);}
function disappeare3(){document.getElementById('question4').style.display="block";}
function countDown(maxtime,fn)
{var timer=setInterval(function()
{if(maxtime>=0){minutes=Math.floor(maxtime/60);seconds=Math.floor(maxtime%60);if(seconds<10&&length.seconds!=2)seconds='0'+seconds;msg=+minutes+":"+seconds+" ";fn(msg);--maxtime;}
else{clearInterval(timer);fn("00:00");}},1000);}
countDown(77,function(msg)
{document.getElementById('timer1').innerHTML=msg;})
