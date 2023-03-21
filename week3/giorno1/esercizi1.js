function numeri(number) {

function to20(number) {
    var values = [
        " ", "uno", "due", "tre", "quattro", "cinque", "sei", "sette", "otto", "nove",
        "dieci", "undici", "dodici", "tredici", "quattordici", "quindici", "sedici",
        "diciassette", "diciotto", "diciannove"
    ]
    return values[number]
}
function to100(number) {
    if (number < 20) return to20(number)
    var values = [ " ", "venti", "trenta", "quaranta", "cinquanta", "sessanta", "settanta", "ottanta", "novanta"]
    return values[(Math.floor(number / 10))] + to20(number % 10)
}


function to1000 (number) {
    if (number< 100) return to100(number)
    var values = "cento"
    return to100([Math.floor(number/100)]) + values + to100(number % 100)
}




function to10000 (number) {
    if (number< 1000) return to1000(number)
    var values = "mila"
    return to1000([Math.floor(number/1000)]) + values + to1000(number % 1000)
}


function to1000000 (number) {
    if (number<100000) return to100000(number)
    var values = "milione"
    return to100000([Math.floor(number/1000000)]) + values + to100000(number %100000)
}

return 1000000(number);

}

for (i = 1000000; i<1000000; i++ ) {
    console.log(numeri(i));


}