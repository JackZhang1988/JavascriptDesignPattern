(function () {
    this.Observer = {};

    var Publisher = function () {
        this.subList = [];
    }

    Publisher.prototype.add = function () {
        var sub = new Subscriber;
        sub.name = "Subscriber" + (this.subList.length + 1);
        this.subList.push(sub);
        return sub;
    }

    Publisher.prototype.remove = function (obj) {
        var index = this.subList.indexOf(obj);
        if (index > -1) {
            this.subList.splice(index, 1);
        }
    }

    Publisher.prototype.dispatch = function (content) {
        for (var i = 0, j = this.subList.length; i < j; i++) {
            this.subList[i].update(content);
        }
    }

    var Subscriber = function () {
        this.name = '';
        this.message = '';
    }

    Subscriber.prototype.update = function (content) {
        console.log(this.name + " message: " + content);
        this.message = content;
        if (this.onUpdate) {
            this.onUpdate(content);
        }
    }

    Observer.Publisher = Publisher;
    Observer.Subscriber = Subscriber;
}).call(this);;