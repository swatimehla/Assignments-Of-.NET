//Decorators in Typescript Exmples

let Lipstick = function (target) {
    target.lips = 'Pink';
}

let Earrings = function (target) {
    target.HasEarring = true;
}

@Lipstick
@Earrings
class Girls {

}
console.log("Her Lips are $(Girls.lips)");
console.log("She has Earrings=$(Girls.HasEarrings)");