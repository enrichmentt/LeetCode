package reverse_string

import (
	"reflect"
	"testing"
)

func TestReverseString(t *testing.T) {
	want := []byte{'o', 'l', 'l', 'e', 'h'}
	input := []byte{'h', 'e', 'l', 'l', 'o'}
	ReverseString(input)

	if !reflect.DeepEqual(want, input) {
		t.Errorf("ReverseString = %d; want %d", input, want)
	}
}
