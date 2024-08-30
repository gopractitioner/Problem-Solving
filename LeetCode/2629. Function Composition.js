/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function (functions) {

    return function (x) {
        // solution 1
        reversedFunctions = functions.reverse();
        reversedFunctions.forEach(
            f => {
                x = f(x)
            }
        )
        return x

        // solution 2
        reversedFunctions = functions.reverse();
        return reversedFunctions.reduce(
            (accumulator, currentValue) => {
                return currentValue(accumulator)
            }, x
        )
    }
};

/**
 * const fn = compose([x => x + 1, x => 2 * x])
 * fn(4) // 9
 */