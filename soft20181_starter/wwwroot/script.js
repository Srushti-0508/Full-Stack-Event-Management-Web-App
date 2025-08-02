/*------Increase/ Decrease font Size ------*/
var fonts = document.querySelector(".nav");
var increase = document.querySelector(".inc_btn");
var decrease = document.querySelector(".dec_btn");
var reset = document.querySelector(".rst_btn")
var fontSz = 22;

/*------Increase font Size ------*/
function inc_font(){
const selectFont = fontSz + 3 +'px';
nav.style.fontSize = selectFont; 
localStorage.setItem('UserInFont', selectFont)

}
increase.addEventListener('click', inc_font);


/*-----Reset font Size ------*/
function reset_font(){
const selectFont = fontSz +'px';
nav.style.fontSize = selectFont; 
localStorage.setItem('UserInFont', selectFont)
  
}
reset.addEventListener('click', reset_font);


/*------Decrease font Size ------*/ 
function dec_font(){
  const selectFont = fontSz - 2 +'px';
nav.style.fontSize = selectFont; 
localStorage.setItem('UserInFont', selectFont)
  
}
decrease.addEventListener('click', dec_font);


/*------change bg ------*/ 

var bg = document.getElementById('#header');
var darkbg_btn = document.querySelector(".darkbg_btn");
var lightbg_btn = document.querySelector(".lightbg_btn");
var resetbg_btn =document.querySelector(".resetbg_btn")


function dark_bg(){
const selectbg="black";
header.style.background= selectbg; 
localStorage.setItem('UserInBg', selectbg)
}
darkbg_btn.addEventListener('click', dark_bg);

function light_bg(){
const selectbg="linear-gradient(#fff,#c8f1ff)";
header.style.background= selectbg; 
localStorage.setItem('UserInBg', selectbg)
}
lightbg_btn.addEventListener('click', light_bg);

function original_bg(){
const selectbg="#2b2a2a";
header.style.background= selectbg; 
localStorage.setItem('UserInBg', selectbg)
}
resetbg_btn.addEventListener('click', original_bg)

window.onload =function(){
  if('UserInBg' in localStorage){
    const ChooseBg = localStorage.getItem('UserInBg');
    header.style.background= ChooseBg; 
    
      }
if('UserInFont' in localStorage){
    const ChooseFont = localStorage.getItem('UserInFont');
    nav.style.fontSize= ChooseFont; 
    
 }
}


