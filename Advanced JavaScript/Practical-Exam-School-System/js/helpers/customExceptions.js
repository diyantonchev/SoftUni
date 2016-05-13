function ArgumentException(expected) {
    this.name = 'Argument Exception';
    this.message = 'Invalid argument: expected "' + expected + '" value type.';
    this.stack = (new Error()).stack;
}

ArgumentException.prototype = Object.create(Error.prototype);