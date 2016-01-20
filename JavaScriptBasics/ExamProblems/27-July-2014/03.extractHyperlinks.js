function solve(args) {
    var html = args.join('\n');
    var regex = /<a\s+([^>]+\s+)?href\s*=\s*('([^']*)|"([^"]*)|([^\s>]*))[^>]*/g;
    var match;
    while (match = regex.exec(html)) {
        var hrefValue = match[3];
        if (hrefValue === undefined) {
            hrefValue = match[4];

            if (hrefValue === undefined) {
                hrefValue = match[5];
            }
        }

        console.log(hrefValue);
    }
}
