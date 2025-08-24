class Solution:
    def __init__(self):
        self.roman_numeral_map = {
            'I': 1,
            'V': 5,
            'X': 10,
            'L': 50,
            'C': 100,
            'D': 500,
            'M': 1000
        }
        self.ans = 0

    def romanToInt(self, s: str) -> int:
        i:int = 0
        while i < len(s):
            if (i + 1 < len(s) and self.roman_numeral_map[s[i]] < self.roman_numeral_map[s[i + 1]]):
                self.ans += self.roman_numeral_map[s[i + 1]] - self.roman_numeral_map[s[i]]
                i += 2
            else:
                self.ans += self.roman_numeral_map[s[i]]
                i += 1
        return self.ans


if __name__ == "__main__":
    solution = Solution()
    print(solution.romanToInt("MCMXCIV"))