var App = {
    signingModel: function (serverModel) {
        this.name = ko.observableArray(serverModel.Sessions);
    }
}