function Car(){
	this.weight=function(){return 1000;}
}

function FruitCargo(car){
	var w=car.weight();
	car.weight=function(){
		return w+100;
	};
}

function AnimalCargo(car){
	var w=car.weight();
	car.weight=function(){
		return w+200;
	};
}

function VegetableCargo(car){
	var w=car.weight();
	car.weight=function(){
		return w+200;
	};
}


function decoratorInit(){
	var car=new Car();
	FruitCargo(car);
	AnimalCargo(car);
	VegetableCargo(car);

	console.log(car.weight());
}

decoratorInit();

function CarFactory(cargoOptions){
	var cargos={},car=new Car();
	//remove duplicate options
	for(var i=0,j=cargoOptions.length;i<j;i++){
		cargos[cargoOptions[i]]=1;
	}
	for(key in cargos){
		switch(key){
			case "Fruit": 
				FruitCargo(car);
				break;
			case "Animal":
				AnimalCargo(car);
				break;
			case "Vegetable":
				VegetableCargo(car);
				break;
			default:
				return null;
		}
	}
	return car;
}

function factoryInit(){
	var car=CarFactory(['Fruit','Vegetable','Fruit','Animal','Animal']);

	console.log(car.weight());
}

factoryInit();