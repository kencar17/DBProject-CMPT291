Imports CloudinaryDotNet
Imports CloudinaryDotNet.Actions

Public Class Faces
    Shared ReadOnly MyAccount As New Account(
        "dmhf7fjrc",
        "749328395684734",
        "SX7dqZI3VEwsmodIYONlV2MPYSw")
    Shared cloudinary As New Cloudinary(MyAccount)

    Public Shared Function upload(filepath As String) As String
        Dim uploadParams As New ImageUploadParams
        Dim transform As New Transformation()
        With transform
            .Width(100)
            .Height(141)
            .Crop("scale")
        End With

        With uploadParams
            .File = New FileDescription(filepath)
            .Transformation = transform
            .Format = "png"
        End With

        Return cloudinary.Upload(uploadParams).JsonObj.Item("secure_url")
    End Function

    Public Shared Function uploadVehicle(filepath As String) As String
        Dim uploadParams As New ImageUploadParams
        Dim transform As New Transformation()
        With transform
            .Width(113)
            .Height(75)
            .Crop("scale")
        End With

        With uploadParams
            .File = New FileDescription(filepath)
            .Transformation = transform
            .Format = "png"
        End With

        Return cloudinary.Upload(uploadParams).JsonObj.Item("secure_url")
    End Function
End Class
