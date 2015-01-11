import java.util.Comparator;
import java.util.Map;

class MyComparator implements Comparator<Integer> {

		Map<Character, Integer> map;

		public MyComparator(Map<Character, Integer> map) {
			this.map = map;
		}

		public int compare(Integer o1, Integer o2) {

			return ((Integer) map.get(o2)).compareTo((Integer) map.get(o1));

		}
	}