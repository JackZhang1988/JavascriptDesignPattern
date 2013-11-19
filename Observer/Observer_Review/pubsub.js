var pubsub={};

(function(q){
	var topics={};
	var tokenid=-1;

	q.publish=function(topic,args){
		if(!topics[topic]){
			return false;
		}
		var subs=topics[topic],len=subs?topics[topic].length:0;
		while(len--){
			subs[len].func(topic,args);
		}
	};
	q.subscribe=function(topic,func){
		if(!topics[topic]){
			topics[topic]=[];
		}
		var token = (++tokenid).toString();
		topics[topic].push({
			token:token,
			func:func
		});
	};
	q.unsubscribe=function(token){
		for ( var m in topics ) {
            if ( topics[m] ) {
                for ( var i = 0, j = topics[m].length; i < j; i++ ) {
                    if ( topics[m][i].token === token) {
                        topics[m].splice( i, 1 );
                        return token;
                    }
                }
            }
        }
        return this;
	};
})(pubsub)



function init(){
	var messageLogger = function ( topics, data ) {
    	console.log( "messagelog1 Logging: " + topics + ": " + data );
	};	
	var messageLogger2 = function ( topics, data ) {
    	console.log( "messagelog2 Logging: " + topics + ": " + data );
	};
	var sub1_1=pubsub.subscribe("event1",messageLogger);
	var sub1_2=pubsub.subscribe("event1",messageLogger);
	var sub2_1=pubsub.subscribe("event2",messageLogger2);
	var sub2_2=pubsub.subscribe("event2",messageLogger2);

	pubsub.publish( "event1", "hello world!" );
	pubsub.publish( "event2", "hello everyone!");

}
init();