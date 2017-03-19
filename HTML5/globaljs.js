function doFirst(){
	dropzone=document.getElementById('dropzone');	
	dropzone.addEventListener("drop",dropped,false);
	dropzone.addEventListener("dragover",dragover,false);	
	dropzone.addEventListener("dragleave",dragleave,false);	
}
function upload(files){
	console.log(files);
}


function dropped(e){	
	dropzone.ondrop=function(e){
			e.preventDefault();	
			this.className='dropzone';	
			//console.log(e.dataTransfer.files);
			upload(e.dataTransfer.files);
		};
}
function dragover(e){	
	dropzone.ondragover=function(){
			//e.preventDefault();
			this.className='dropzone dragover';
			return false;
		};
}
function dragleave(e){
	dropzone.ondragleave=function(){
			//e.preventDefault();
			this.className='dropzone';
			return false;
		};	
}
window.addEventListener("load",doFirst,false);