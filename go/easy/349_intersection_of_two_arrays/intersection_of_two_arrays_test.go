package intersection_of_two_arrays

import (
	"reflect"
	"testing"
)

func TestIntersection(t *testing.T) {
	tests := []struct {
		name string
		arr1 []int
		arr2 []int
		want []int
	}{
		{"Test1", []int{1, 2, 2, 1}, []int{2, 2}, []int{2}},
		{"Test2", []int{4, 9, 5}, []int{9, 4, 9, 8, 4}, []int{9, 4}},
	}

	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			r := Intersection(tt.arr1, tt.arr2)
			if !reflect.DeepEqual(tt.want, r) {
				t.Errorf("%s got %v, want %v", tt.name, r, tt.want)
			}
		})
	}
}
