var App = {
    signingModel: function (serverModel) {
        var self = this;
        self.sessions = ko.observableArray(ko.utils.arrayMap(serverModel.Sessions, function (signingSession) {
            return {
                name: signingSession.Name,
                lineOfBusiness: signingSession.LineOfBusiness,
                documents: ko.observableArray(signingSession.Documents),
                displayPdf: function (pdfName) {
                    $('#signingPdf').attr('data', '/Content/' + pdfName + '.pdf');
                    // Work around reloading object
                    App.reloadObjectWorkAround();
                }
            };
        }));
        
    },
    register: function () {
        
    },
    reloadObjectWorkAround: function(){
        var newObject = $('#signingPdf').clone();
        $('#signingPdf').remove();
        $('#signingWindow').append(newObject);
    }
}