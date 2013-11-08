var Subject=function(){
	this.observerList=[];
}
Subject.prototype.add=function(obj){
	this.observerList.push(obj);
}
Subject.prototype.remove=function(obj){
	var index=this.observerList.indexOf(obj);
	if(index > -1){
		this.observerList.splice(index,1);
	}
}
Subject.prototype.dispatch=function(content){
	for(var i=0,j=this.observerList.length;i<j;i++){
		this.observerList[i].update(content);
	}
}

var Observer=function(){
	this.name='';
	this.message='';
	this.update=function(content){
		console.log(this.name+" message: "+content);
		this.message=content;
	};
}
var sub;
function init(){
	sub=new Subject;
}

init();

function addObserver(){
	var obs=new Observer;
	obs.name="observer"+(sub.observerList.length+1);

	sub.add(obs);

	var element=document.createElement("li");
	var liContent=document.createTextNode(obs.name);
	element.appendChild(liContent);
	var obList=document.getElementById("observerList");
	obList.appendChild(element);	
}

function dispatchMessage(){
	var element=document.getElementById("message");
	if(element.value){
		sub.dispatch(element.value);
	}
	updateList();
}

function updateList(){
	var obList=document.getElementById("messageList");
	var ulEle=document.createElement("ul");
	for (var i = 0,j=sub.observerList.length; i <j; i++) {
		var element=document.createElement("li");
		var liContent=document.createTextNode(sub.observerList[i].name+" message: "+sub.observerList[i].message);
		element.appendChild(liContent);
		ulEle.appendChild(element)
	};
	obList.appendChild(ulEle);	
}