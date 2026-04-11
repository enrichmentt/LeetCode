package valid_palindrome

import (
	"testing"
)

func TestIsValidPalindrome(t *testing.T) {
	tests := []struct {
		name  string
		input string
		want  bool
	}{
		{"test1", "A man, a plan, a canal: Panama", true},
		{"test2", "0P", false},
		{"test3", "race a car", false},
		{"test4", " ", true},
	}

	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			if got := IsPalindrome(tt.input); got != tt.want {
				t.Errorf("%s got %t, want %t", tt.name, got, tt.want)
			}
		})
	}
}
