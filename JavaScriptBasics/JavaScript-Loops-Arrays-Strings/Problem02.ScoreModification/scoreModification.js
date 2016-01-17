var arr = [200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1];

var filtered = arr.filter(function(score){
    return 0 <= score && score <= 400;
}).map(function(score){
    var downward = 0.2 * score;
    return score -= downward;
}).sort(function(x, y){
    return x > y;
});

console.log(filtered);
