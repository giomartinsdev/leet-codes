class Solution:
    def trim_space(self, string: str) -> str:
        return string.strip()
    
    def is_an_natural_number(self, string: str) -> bool:
        if string and string[0] == '-':
            return False
        return True

    def remove_letters(self, string: str) -> str:
        if not string:
            return ""
        
        result = ""
        i = 0
        
        if string[0] in ['+', '-']:
            result += string[0]
            i = 1
        
        while i < len(string) and string[i].isdigit():
            result += string[i]
            i += 1
            
        return result
    
    def int32_overflow(self, integer: int) -> int:
        if integer > 2**31 - 1:
            return 2**31 - 1
        elif integer < -2**31:
            return -2**31
        return integer

    def myAtoi(self, s: str) -> int:
        result: str = self.trim_space(s)
        if not result:
            return 0
            
        result = self.remove_letters(result)
        
        if not result or result in ['+', '-']:
            return 0
        
        try:
            num = int(result)
            return self.int32_overflow(num)
        except ValueError:
            return 0