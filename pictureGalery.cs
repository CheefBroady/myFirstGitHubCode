// declaer array
var bilder = new Array();

// pic pictures
function initBilder(){
    for(var i = 0; i<=99; i++){
        if(i<10){
            bilder[i]="Bilder/Bild00"+i+".png";
        }
        else{
            bilder[i]="Bilder/Bild0"+i+".png";
        }
    }
}

var currBild=0; // Bildzaehler
fucntion showBild(){
    var nuBi=window.document.getElementById("Bildbereich");
    nuBi.src=bilder[currBild];
}


function nextBild(){
    if(currBil<=bilder.length){
        currBild++;
        showBild();
    }
}


function prevBild(){
    if(currBild>0){
        currBild--;
        showBild();
    }
}


function initBild(){
    currBild=0;
    showBild();
}


function slideShowInit(){
    initbild();
    slideShow();
}


fundtion slideShow(){
    nextBild();
    window.setTimeout(slideShow, 3000); // Angabe Timeout in Milliskeunden
}