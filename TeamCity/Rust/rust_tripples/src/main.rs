fn main() {
    let mut m = 3;
    while m < 50 {
        let mut n = 1;
        while n < m {
        let t = triple_by_euclidian(m, n);
            println!("{0}*{0} + {1}*{1} = {2}*{2}", t.0, t.1, t.2);
            println!("[{0} + {1} = {2}]", t.0.pow(2), t.1.pow(2), t.2.pow(2));
                n += 2;
            }
        m += 2;
    }
}

fn triple_by_euclidian(m :u32, n :u32) -> (u32, u32, u32)
{
    if (m <= n || n <= 0) panic!("impossible arguments");
	let a = m * n;
	let b = (m * m - n * n) / 2;
	let c = (m * m + n * n) / 2;

 (a, b, c)
}
