

function my_Dictionary() {//dictionary with keys//
    var Chopper = {
        Engine: "v-twin",
        displacement: "1500 cc",
        color: "black and red",
        pipes: "custom",
        Sound: "LOUD!"
    };
    delete Chopper.Sound;//will return "undefined"//
    document.getElementById("Dictionary").innerHTML = Chopper.Sound;
}