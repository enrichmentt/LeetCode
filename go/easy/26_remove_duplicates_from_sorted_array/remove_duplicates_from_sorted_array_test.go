package remove_duplicates_from_sorted_array

import (
	"reflect"
	"testing"
)

func TestRemoveDuplicates(t *testing.T) {
	tests := []struct {
		name  string
		input []int
		want  int
	}{
		{"Test1", []int{0, 0, 1, 1, 1, 2, 2, 3, 3, 4}, 5},
		{"Test2", []int{1, 1, 2}, 2},
		{"Test3", []int{1, 1}, 1},
	}

	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			r := RemoveDuplicates(tt.input)
			if !reflect.DeepEqual(tt.want, r) {
				t.Errorf("%s got %v wand %v", tt.name, tt.want, r)
			}
		})
	}
}
