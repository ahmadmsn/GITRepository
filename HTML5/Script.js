function getStuff(){
	// document.querySelector('#tuna').onclick=talk;
	var list = document.querySelectorAll('#tuna');
	for(var i=0; i<list.length; i++)
	{
	 list[i].onclick=talk;
	}	
}
function talk(){
	alert('yoyoma');
}
window.onload=getStuff;