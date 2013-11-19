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