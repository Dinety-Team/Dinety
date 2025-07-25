/// # License
/// ## Original Text

/**

Dinety Copyright (C) 2025 Dinety Team. All Rights Reserved.

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.

*/

/// License Original Text: <https://www.gnu.org/licenses/gpl-3.0.html#license-text>

/// ## Chinese Translation

/**

Dinety 版权所有 (C) 2025 Dinety Team。 保留所有权利。

本程序是自由软件：您可以根据自由软件基金会发布的 GNU 通用公共许可证的条款重新分发它和/或修改它，许可证版本为第 3 版，或者（您可以选择）任何更高版本。

本程序的分发是希望它有用，但没有任何担保；甚至没有适销性或特定用途适用性的默示担保。详情请参阅 GNU 通用公共许可证。

您应该已经收到 GNU 通用公共许可证的副本。如果没有，请参阅 <https://www.gnu.org/licenses/>。

*/

/// 许可证原文: <https://www.gnu.org/licenses/gpl-3.0.html#license-text>

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
