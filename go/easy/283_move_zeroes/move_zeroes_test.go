package move_zeroes

import (
	"reflect"
	"testing"
)

func TestMoveZeroes(t *testing.T) {
	tests := []struct {
		name  string
		input []int
		want  []int
	}{
		{"Test1", []int{0, 1, 0, 3, 0, 12}, []int{1, 3, 12, 0, 0, 0}},
		{"Test2", []int{0}, []int{0}},
		{"Test3", []int{0, 0, 0, 1, 1, 1}, []int{1, 1, 1, 0, 0, 0}},
	}

	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			MoveZeroes(tt.input)
			if !reflect.DeepEqual(tt.want, tt.input) {
				t.Errorf("%s got %v, want %v", tt.name, tt.input, tt.want)
			}
		})
	}
}
