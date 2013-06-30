var App = {
    signingModel: function (serverModel) {
        this.sessions = ko.observableArray(serverModel.Sessions);
    }
}