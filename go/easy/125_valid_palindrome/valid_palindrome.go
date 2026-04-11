package valid_palindrome

import (
	"strings"
	"unicode"
)

func IsPalindrome(s string) bool {
	var sb strings.Builder

	for _, v := range s {
		if unicode.IsLetter(v) || unicode.IsDigit(v) {
			sb.WriteRune(v)
		}
	}

	s = sb.String()
	s = strings.ToUpper(s)

	start, end := 0, len(s)-1

	for start < end {
		if s[start] != s[end] {
			return false
		}

		start++
		end--
	}

	return true
}
