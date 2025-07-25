/// Copyright (C) 2025 Dinety Team All Rights Reserved 
/// 版权所有 (C) Dinety Team 保留所有权利

#[unsafe(no_mangle)]
pub extern "C" fn add(left: u64, right: u64) -> u64 {
    left + right
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn it_works() {
        let result = add(2, 2);
        assert_eq!(result, 4);
    }
}
