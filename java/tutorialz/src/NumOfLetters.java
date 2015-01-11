import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Comparator;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedHashMap;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.stream.Collectors;

public class NumOfLetters {

	// read text method
	private static void read() throws IOException {
		String text = null;
		BufferedReader reader = new BufferedReader(new InputStreamReader(
				System.in));
		System.out.print("Please input some text: ");
		try {
			text = reader.readLine().toString();
		} catch (Exception e) {
			System.in.close();
			System.err.println("error : " + e.getMessage());
		}
		text.toUpperCase();
		analyse(text);

	}

	// Analyse the text method
	private static void analyse(String input) {

		// remove invalid characters
		char[] rawData = input.toCharArray();
		Arrays.sort(rawData);
		int counter = 0;
		boolean valid = false;
		while (valid == false) {
			valid = Character.isLetter(rawData[counter]);
			counter++;
		}
		char[] letters = Arrays.copyOfRange(rawData, counter,
				rawData.length - 1);
		System.out.println();

		HashMap<Character, Integer> m = new HashMap<Character, Integer>();
		for (char c2 : letters) {
			Integer times = m.get(c2);
			m.put(c2, (times == null) ? 1 : times + 1);
		}

		@SuppressWarnings("unchecked")
		Map<Character, Integer> map = new LinkedHashMap<Character, Integer>(
				sortByValues(m)); // this is the sorted map from which the
									// values are taken for printing

		List<Integer> valList = new ArrayList<Integer>(map.values());
		List<Character> keyList = new ArrayList<Character>(map.keySet());

		// filter unique elements
		Set<Integer> unique = (Set<Integer>) valList.stream().collect(
				Collectors.toSet());

		System.out.println("Most common letters: ");
		System.out.println();

		int number = 20; // for the max amount of '#' signs

		for (int i = 1; i <= valList.size() && i <= 20; i++) {

			String symbols = graphStyle(number);
			try {
				if (i == valList.size()) {
					// simple way to get out of the index out of bounds
					// exception
				} else {
					if (valList.get(i - 1) != valList.get(i)) {
						if (unique.size() < 4) {
							number /= unique.size(); // best way I found to
														// print the 
														// graph, not perfect
														// but does work
						} else {
							number /= 2;
						}

					}
				}
			} catch (ArrayIndexOutOfBoundsException e) {
				continue;
			}
			System.out.println(keyList.get(i - 1) + ": " + valList.get(i - 1)
					+ " " + symbols);

		}

	}

	//
	public static String graphStyle(int a) {

		String one = "####################";
		String two = one.substring(0, (a == 0) ? 1 : a); // this deals with less
															// than 1 symbol
															// cases
		return two;

	}

	
	public static void main(String[] args) throws IOException {
		read();

	}

	@SuppressWarnings({ "rawtypes", "unchecked" })
	private static HashMap sortByValues(HashMap map) {
		List list = new LinkedList(map.entrySet());
		// defined custom comparator for descending sorting
		Collections.sort(list, new Comparator() {
			@Override
			public int compare(Object o1, Object o2) {
				return ((Comparable) ((Map.Entry) (o2)).getValue())
						.compareTo(((Map.Entry) (o1)).getValue());
			}
		});

		// the list is copied in a HashMap
		// using LinkedHashMap to preserve the insertion order
		HashMap sortedHashMap = new LinkedHashMap();
		for (Iterator it = list.iterator(); it.hasNext();) {
			Map.Entry entry = (Map.Entry) it.next();
			sortedHashMap.put(entry.getKey(), entry.getValue());
		}
		return sortedHashMap;
	}
}
