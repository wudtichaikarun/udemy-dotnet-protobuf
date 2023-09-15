# udemy-dotnet-protobuf

## default value

| Data Type     | Default Value                            |
| ------------- | ---------------------------------------- |
| `string`      | Empty string                             |
| `bool`        | `false`                                  |
| Numeric types | Zero                                     |
| Enums         | The first defined enum value (must be 0) |
| `bytes`       | Empty bytes                              |

![alt debug_default_value](/images/enum_debug.png "Enum default value")

MaritalStatus is Single because first value from \*.proto of enum is Single

![alt protobuf](/images/proto.png "Enum")
