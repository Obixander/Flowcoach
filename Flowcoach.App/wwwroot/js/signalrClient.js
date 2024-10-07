window.connectionManager = {
    connection: null,

    startConnection: function (hubUrl) {
        this.connection = new signalR.HubConnectionBuilder()
            .withUrl(hubUrl)
            .build();

        return this.connection.start();
    },

    sendMessage: function (user, message) {
        return this.connection.invoke("SendMessage", user, message);
    },

    onReceiveMessage: function (callback) {
        this.connection.on("ReceiveMessage", function(user, message) {
            callback(user, message);
        });
    }
};
