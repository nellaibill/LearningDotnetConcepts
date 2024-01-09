var connectionUserCount = new signalR.HubConnectionBuilder().withUrl("/hubs/userCount").build();

connectionUserCount.on("UpdateTotalViews", (value) => {
    console.log("UpdateTotalViews event triggered");
    var newCountSpan = document.getElementById("totalViewsCounter");
    console.log(newCountSpan); // Log the element to the console
    newCountSpan.innerText = value.toString();
});

function newWindowLoadedOnClient() {
    connectionUserCount.send("NewWindoLoaded");
}


function fulfilled() {
    console.log("conneciton successfull for signal");
    newWindowLoadedOnClient();
}

function rejected() {

}

connectionUserCount.start().then(fulfilled, rejected);