function f(v, n) {
    if (n == 0)
        return 0;
    else {
        let s;
        s = f(v, n - 1);
        if (v[n - 1] > 0) s = s + v[n - 1];
        return s;
    }
}

const resultado = f([2, -4, 7, 0, -1, 4], 6);

console.log(resultado);