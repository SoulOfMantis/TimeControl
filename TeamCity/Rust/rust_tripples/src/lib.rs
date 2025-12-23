#[cfg(test)]
mod tests {
    #[test]
    #[should_panic]
    fn test_negative() {
        triple_by_euclidian(3, -1);
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
}