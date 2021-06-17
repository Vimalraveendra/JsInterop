
// calling javascript method from blazor
function JSAlert() {
    console.log("hello")
}

function FindSum(no1, no2) {
    sum = parseInt(no1) + parseInt(no2);
    return sum;
}

// calling blazor method from javascript

function GetNumber(num) {
    var result = DotNet.invokeMethodAsync("example", 'ReturnArrayAsync', parseInt(num));
    result.then(function (val) {
        document.getElementById("noIndex").innerHTML = val;
    });
}


function SayHello(name) {
    DotNet.invokeMethodAsync("example", "ShowHello", name);
}


function CallCalculateDivision(no1, no2) {
    var result = DotNet.invokeMethodAsync("example", "CalculateDivision", parseInt(no1), parseInt(no2));
    result.then(function (val) {
        document.getElementById("mResult").innerHTML = val;
    });
}