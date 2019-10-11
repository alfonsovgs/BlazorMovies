function dotnetCall() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
        .then(result => {
            console.log("Value is: " + result);
        });
}

function dotnetMethodInstanceCall(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}