import com.fasterxml.jackson.databind.ObjectMapper;
import java.io.File;
import java.util.Map;
import java.util.List;

public class DeserializeJsonFromFile {
    public static void main(String[] args) throws Exception {
        ObjectMapper mapper = new ObjectMapper();
        File jsonFile = new File("path/to/your/file.json");
        Map<String, List<String>> data = mapper.readValue(jsonFile, Map.class);

        System.out.println(data);
    }
}
