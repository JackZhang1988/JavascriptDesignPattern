
var c, context,myCar;

var MovableComponent = function(){
	this.child=[];
	this.x=100;
	this.y=100;
	this.moveStep=1;
}

MovableComponent.prototype={
	add:function(cg){
		this.child.push(cg);
	},
	remove:function(cg){
		for(var i=0,node;node=getCargo(i);i++){
			if(node==cg){
				this.child.splice(i,1);
			}
		}
	},
	getChild:function(i){
		return this.child[i];
	},
	move:function(direction){
		switch(direction){
			case "left": 
				this.x--; break;
			case "right":
				this.x++; break;
			case "up":
				this.y--; break;
			case "down":
				this.y++; break;
			default: 
				return;
		}
	},
	draw:function(){},
	moveAll:function(direction){
		this.move(direction);
		for(var i=0;i<this.child.length;i++){
			this.child[i].moveAll(direction);
		}
	},
	drawAll:function(){
		this.draw();
		for(var i=0;i<this.child.length;i++){
			this.child[i].drawAll();
		}
	}
}

var Car = function(){
}
var Car=function(){
	this.x=100;
	this.y=100;
}

Car.prototype=new MovableComponent;
Car.prototype.draw=function(){
	context.beginPath();
	context.arc(this.x,this.y,10,0,2*Math.PI,false);
	context.arc(this.x+100,this.y,10,0,2*Math.PI,false);
	context.rect(this.x-15,this.y-30,130,20);
	context.fillStyle = 'green';
	context.fill();	
}

var LEFT=37,UP=38,RIGHT=39,DOWN=40;
document.onkeydown=function(e){
	context.clearRect(0,0,500,500);

	if(e.keyCode==LEFT){
		myCar.moveAll("left");
	}
	if(e.keyCode==RIGHT){
		myCar.moveAll("right");
	}
	if(e.keyCode==UP){
		myCar.moveAll("up");
	}
	if(e.keyCode==DOWN){
		myCar.moveAll("down");
	}
	myCar.drawAll();
}

var Fruit=function(){
	this.x=100;
	this.y=65;
	this.color="red";
}
Fruit.prototype=new MovableComponent;
Fruit.prototype.draw=function (){
	context.beginPath();
	context.arc(this.x,this.y,5,0,2*Math.PI,false);
	context.fillStyle = this.color;
	context.fill();	
	console.log("fruit draw");	
}

var littleCar=function(){
	this.x=120;
	this.y=70;
	this.color="black";
}
littleCar.prototype=new MovableComponent;

littleCar.prototype.draw=function(){
	context.beginPath();
	context.arc(this.x,this.y,5,0,2*Math.PI,false);
	context.arc(this.x+50,this.y,5,0,2*Math.PI,false);
	context.rect(this.x-10,this.y-10,60,10);
	context.fillStyle = this.color;
	context.fill();	
	console.log("little Car Draw");
}

function init(){
	c=document.getElementById("myCanvas");
	context=c.getContext("2d");
	myCar=new Car();

	var apple=new Fruit();
	var lcar=new littleCar();
	var pear=new Fruit();
	pear.x=150;
	pear.y=55;
	lcar.add(pear);

	myCar.add(apple);
	myCar.add(lcar);
	myCar.drawAll();
}
init();