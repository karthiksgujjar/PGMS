const slider = document.getElementById('screenshots-slider');
const images = slider.firstElementChild.children;
const imageBubbles = slider.lastElementChild.children;
let imageNumber = 0;

setInterval(() =>{
    images[imageNumber].setAttribute("hidden", true);
    imageBubbles[imageNumber].innerHTML = '&bullet;';
    showImage((imageNumber != 9)?++imageNumber:imageNumber=0);
},3000);

function showImage(imageNumber){
    images[imageNumber].removeAttribute("hidden");
        imageBubbles[imageNumber].innerHTML = '&bigodot;';
        images[imageNumber].style = "animation: fadeIn 1s ease-in-out;";
}

function openMailTo(){
    const sendMailLink = document.createElement('a');
    sendMailLink.href = `mailto:gfgctumkur.pgms.bca6.2023@gmail.com?&subject=Comment on SLS from ${document.getElementById('name').value} &body=${document.getElementById('comment').value}`;
    sendMailLink.click();
}