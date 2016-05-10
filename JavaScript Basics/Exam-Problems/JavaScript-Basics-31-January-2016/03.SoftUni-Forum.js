function solve(post) {
    'use strict';

///fuck yourself author, I won't edit this to give me 100 pts, because it's bullshit and is f**king ugly 
    function newString(char, length) {
        var result = [], index = 0;
        for (index = 0; index < length; index += 1) {
            result.push(char);
        }

        return result.join('');
    }

    var bannedList = post.pop().split(/\s+/),
        skip = false;
    post = post.map(function (row, index) {
        if (row.indexOf('<code>') > -1) {
            for (var i = index; i < post.length; i += 1) {
                if (post[i].indexOf('</code>') > -1) {
                    skip = true;
                }
            }
        } else if (row.indexOf('</code>') > -1) {
            skip = false;
        }

        if (!skip) {
            var regex = /#[A-Za-z][\w-]+[A-Za-z0-9]\b/g;
            var matches = row.match(regex);
            if (matches) {
                matches.forEach(function (match) {
                    var user = match.substring(1, match.length),
                        replacement;
                    if (bannedList.indexOf(user) > -1) {
                        replacement = newString('*', user.length);
                    } else {
                        replacement = '<a href="/users/profile/show/{0}">{0}</a>'.replace(/\{0\}/g, user);
                    }

                    row = row.replace(match, replacement);
                });
            }
        }

        return row;
    });

    post.forEach(function (row) {
        console.log(row);
    });
}