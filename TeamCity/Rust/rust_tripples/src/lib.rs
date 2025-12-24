#[cfg(test)]
mod tests {
    #[test]
    #[should_panic]
    fn test_zero() {
        triple_by_euclidian(3, 0);
    }

    #[test]
    #[should_panic]
    fn test_equal() {
        triple_by_euclidian(3, 3);
    }

    #[test]
    fn test_normal() {
        let t = triple_by_euclidian(3, 1);
        assert_eq!(t.0, 3);
        assert_eq!(t.1, 4);
        assert_eq!(t.2, 5);
        assert_eq!(t.0.pow(2) + t.1.pow(2), t.2.pow(2));
    }

    fn triple_by_euclidian(m :u32, n :u32) -> (u32, u32, u32){
    if m <= n || n <= 0 {panic!("impossible arguments")};
	let a = m * n;
	let b = (m * m - n * n) / 2;
	let c = (m * m + n * n) / 2;
    (a, b, c)
    }
}
