
var stateMessage="";


var Car={
	state:undefined,

	states:{
		stopping:{
			stateName:'stopping',
			initialize:function(target){
				this.target = target;
			},
			fireup:function(){
				stateMessage="Car is firing up now!";
				this.target.changeState(this.target.states.firing);
			},
			run:function(){
				stateMessage="Firing up Car first!";
			},
			slowDown:function(){
				stateMessage="Car has stopped, can't slow down!";
			},
			stop:function(){
				stateMessage="Car has stopped, can't stop again!";					
			}
		},
		running:{
			stateName:'running',
			initialize:function(target){
				this.target = target;
			},
			fireup:function(){
				stateMessage="Car has run, can't fire up again!";	
			},
			run:function(){
				stateMessage="Car is already running, can't run again!";
			},
			slowDown:function(){
				stateMessage="Car is slowing down!";
				this.target.changeState(this.target.states.slowDowning);
			},
			stop:function(){
				stateMessage="Slowing down the car first!";
			}
		},
		firing:{
			stateName:'fireing',
			initialize:function(target){
				this.target = target;
			},
			fireup:function(){
				stateMessage="Car is firing up now, can't fire up again!"
			},
			run:function(){
				stateMessage="Car is running!";
				this.target.changeState(this.target.states.running);
			},
			slowDown:function(){
				stateMessage="Car hasn't run, can't slow down!";
			},
			stop:function(){
				stateMessage="Car is stopping";
				this.target.changeState(this.target.states.stopping);
			}
		},
		slowDowning:{
			stateName:'slowDowning',
			initialize:function(target){
				this.target = target;
			},
			fireup:function(){
				stateMessage="Car is slowing down now, can't fire up!"
			},
			run:function(){
				stateMessage="Car is running!";
				this.target.changeState(this.target.states.running);
			},
			slowDown:function(){
				stateMessage="Car has slowed down, can't slow down again!";
			},
			stop:function(){
				stateMessage="Car is stopping";
				this.target.changeState(this.target.states.stopping);
			}
		}
	},
	initialize:function(){
		this.states.stopping.initialize(this);
		this.states.running.initialize(this);
		this.states.firing.initialize(this);
		this.states.slowDowning.initialize(this);
		this.state=this.states.stopping;
	},
	fireup:function(){
		this.state.fireup();
	},
	run:function(){
		this.state.run();
	},
	slowDown:function(){
		this.state.slowDown();
	},
	stop:function(){
		this.state.stop();
	},
	changeState:function(state){
		if(this.state != state){
			this.state = state;
			updateStateList("enter state: "+state.stateName);
		}
	}
};

function updateStateList(message){
	var stateList = document.getElementById("showState");
	var element=document.createElement("li");
	var liContent=document.createTextNode(message);
	element.appendChild(liContent);
	stateList.appendChild(element);	
}
Car.initialize();

function fireUp(){
	Car.fireup();
	updateStateList(stateMessage);
}
function run(){
	Car.run();
	updateStateList(stateMessage);
}
function stop(){
	Car.stop();
	updateStateList(stateMessage);
}
function slowDown(){
	Car.slowDown();
	updateStateList(stateMessage);
}
