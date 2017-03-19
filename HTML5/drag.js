function doFirst(){
	mypic=document.getElementById('mypic');
	mypic.addEventListener("dragstart",startdrag,false);
	mypic.addEventListener("dragend",enddrag,false);
	leftbox=document.getElementById('leftbox');
	leftbox.addEventListener("dragenter",dragenter,false);
	leftbox.addEventListener("dragleave",dragleave,false);
	leftbox.addEventListener("dragover",function(e){e.preventDefault();},false);	
	leftbox.addEventListener("drop",dropped,false);
}
function enddrag(e){
	pic=e.target;
	pic.style.visibility='hidden';
}
function dragenter(e){
	e.preventDefault();
	leftbox.style.background="skyblue";
	leftbox.style.border="3px solid green";
}
function dragleave(e){
	e.preventDefault();
	leftbox.style.background="white";
	leftbox.style.border="3px solid blue";
}
function startdrag(e){
	var code='<img src="image/MyPic2.jpg">';
	e.dataTransfer.setData('Text',code);
}
function dropped(e){
	e.preventDefault();
	leftbox.innerHTML=e.dataTransfer.getData('Text');
}
window.addEventListener("load",doFirst,false);